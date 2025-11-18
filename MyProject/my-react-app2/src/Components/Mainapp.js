import React, { useState } from "react";
import Popup from "./popup";

function Mainapp() {
  const [popupMessage, setPopupMessage] = useState(null);
  const [count, setCount] = useState(0);

  return (
    <div style={{ textAlign: "center", marginTop: "50px", color: "blueviolet" }}>
      <h1>Popup Challenge</h1>

      {/* Button 1 */}
      <button
        onClick={() => setPopupMessage("Hi this is the first pop #1")}
        style={{
          padding: "10px 20px",
          backgroundColor: "red",
          color: "black",
          border: "none",
          borderRadius: "10px",
          cursor: "pointer",
          marginRight: "10px",
        }}
      >
        First Popup
      </button>

      {/* Button 2 */}
      <button
        onClick={() => setPopupMessage("Hi this is the second pop #2")}
        style={{
          padding: "10px 20px",
          backgroundColor: "yellow",
          color: "black",
          border: "none",
          borderRadius: "10px",
          cursor: "pointer",
        }}
      >
        Second Popup
      </button>

      {/* Popup appears only when popupMessage is not null */}
      {popupMessage && (
        <Popup
          message={popupMessage}
          count={count}
          onIncrement={() => setCount(count + 1)}
          onDecrement={() => setCount(count - 1)}
          onClose={() => setPopupMessage(null)}
        />
      )}
    </div>
  );
}

export default Mainapp;
