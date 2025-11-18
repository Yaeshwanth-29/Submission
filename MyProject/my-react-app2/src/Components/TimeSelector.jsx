import React, { useState, useEffect } from "react";

export default function Time() {
 
  const [time, setTime] = useState("");       // For live time
  const [color, setColor] = useState("black"); // For selected color

  // useEffect to update time every second
  useEffect(() => {
    const updateTime = () => {
      const now = new Date();
      let hours = now.getHours();
      const minutes = String(now.getMinutes()).padStart(2, "0");
      const seconds = String(now.getSeconds()).padStart(2, "0");
      const ampm = hours >= 12 ? "PM" : "AM";

      // Convert to 12-hour format
      hours = hours % 12 || 12;

      setTime(`${hours}:${minutes}:${seconds} ${ampm}`);
    };

    updateTime(); // Initial call
    const timer = setInterval(updateTime, 1000); // Update every second

    return () => clearInterval(timer); // Cleanup on unmount
  }, []);

  // handle dropdown change
  const handleColorChange = (e) => {
    setColor(e.target.value);
  };

  return (
    <div style={{ textAlign: "center", marginTop: "80px" }}>
      <h1 style={{ color: color }}>Live Time Button</h1>

      {/* Time Button */}
      <button
        style={{
          backgroundColor: color,
          color: "white",
          border: "none",
          borderRadius: "10px",
          padding: "15px 30px",
          fontSize: "18px",
          cursor: "pointer",
        }}
      >
        {time || "Loading..."}
      </button>

      <div style={{ marginTop: "30px" }}>
        {/* Dropdown to choose color */}
        <select
          value={color}
          onChange={handleColorChange}
          style={{
            padding: "10px",
            fontSize: "16px",
            borderRadius: "8px",
            cursor: "pointer",
          }}
        >
          <option value="black">Black</option>
          <option value="red">Red</option>
          <option value="blue">Blue</option>
          <option value="green">Green</option>
          <option value="purple">Purple</option>
        </select>

        {/* Selected color display */}
        <h3 style={{ marginTop: "15px" }}>
          Selected Color: <span style={{ color: color }}>{color}</span>
        </h3>
      </div>
    </div>
  );
}
