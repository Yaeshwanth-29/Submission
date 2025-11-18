import React from "react";
import { useSelector } from "react-redux";

export default function Child() {
  const { username, email, password, submitted } = useSelector(
    (state) => state.form
  );

  const data = { username, email, password };

  return (
    <div
      style={{
        marginTop: "20px",
        backgroundColor: "#eef",
        padding: "15px",
        borderRadius: "10px",
        width: "350px",
        margin: "auto",
        textAlign: "left",
        boxShadow: "0px 2px 8px rgba(0,0,0,0.1)",
      }}
    >
      <h3>Submitted Data (Read Only)</h3>

      {!submitted ? (
        <div
          style={{
            textAlign: "center",
            color: "#555",
            fontSize: "16px",
            marginTop: "15px",
          }}
        >
          ⏳ Waiting for submission before login...
        </div>
      ) : (
        <pre
          style={{
            backgroundColor: "#fff",
            padding: "10px",
            borderRadius: "8px",
            marginTop: "10px",
          }}
        >
          {JSON.stringify(data, null, 2)}
        </pre>
        
      )}
      </div>
  );
}
