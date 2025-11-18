import React from "react";

export default function TimeoutFetch({ setData }) {
  const handleTimeoutFetch = () => {
    setTimeout(async () => {
      const res = await fetch("/api/timeout-data");
      const json = await res.json();
      setData(json.message);
    }, 1000);
  };

  return (
    <button data-testid="btn-timeout" onClick={handleTimeoutFetch}>
      Fetch Timeout
    </button>
  );
}
