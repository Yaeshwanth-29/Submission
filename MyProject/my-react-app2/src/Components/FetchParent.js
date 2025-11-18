import React, { useState } from "react";
import NormalFetch from "./NormalFetch";
import TimeoutFetch from "./TimeoutFetch";
import PromiseFetch from "./PromiseFetch";

export default function FetchParent() {
  const [data, setData] = useState("");

  return (
    <div>
      <NormalFetch setData={setData} />
      <TimeoutFetch setData={setData} />
      <PromiseFetch setData={setData} />

      <h3 data-testid="result">{data}</h3>
    </div>
  );
}
