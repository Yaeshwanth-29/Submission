import React from "react";

export default function NormalFetch({ setData }) {
  const handleNormalFetch = async () => {
    const res = await fetch("/api/data");
    const json = await res.json();
    setData(json.message);
  };

  return (
    <button data-testid="btn-normal" onClick={handleNormalFetch}>
      Fetch Normal
    </button>
  );
}
