import React from "react";

export default function PromiseFetch({ setData }) {
  const handlePromiseFetch = () => {
    fetch("/api/promise-data")
      .then((res) => res.json())
      .then((json) => setData(json.message));
  };

  return (
    <button data-testid="btn-promise" onClick={handlePromiseFetch}>
      Fetch Promise
    </button>
  );
}
