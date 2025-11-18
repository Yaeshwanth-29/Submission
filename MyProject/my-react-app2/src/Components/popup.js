import React from "react";

function Popup({ message, count, onIncrement, onDecrement, onClose }) {
  return (
    <div
      style={{
        position: "fixed",
        top: 0,
        left: 0,
        width: "100%",
        height: "100%",
        backgroundColor: "rgba(0,0,0,0.5)",
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
      }}
    >
      <div
        style={{
          backgroundColor: "white",
          padding: "20px",
          borderRadius: "10px",
          textAlign: "center",
          minWidth: "300px",
        }}
      >
        <h2>{message}</h2>
        <p style={{ fontSize: "18px", fontWeight: "bold" }}>Count: {count}</p>

        <div style={{ margin: "10px 0" }}>
          <button
            onClick={onIncrement}
            style={{
              marginRight: "10px",
              padding: "8px 16px",
              backgroundColor: "green",
              color: "white",
              border: "none",
              borderRadius: "6px",
              cursor: "pointer",
            }}
          >
            Increase
          </button>

          <button
            onClick={onDecrement}
            style={{
              padding: "8px 16px",
              backgroundColor: "red",
              color: "white",
              border: "none",
              borderRadius: "6px",
              cursor: "pointer",
            }}
          >
            Decrease
          </button>
        </div>

        <button
          onClick={onClose}
          style={{
            marginTop: "10px",
            padding: "8px 16px",
            backgroundColor: "blue",
            color: "white",
            border: "none",
            borderRadius: "6px",
            cursor: "pointer",
          }}
        >
          Exit
        </button>
      </div>
    </div>
  );
}

export default Popup;
