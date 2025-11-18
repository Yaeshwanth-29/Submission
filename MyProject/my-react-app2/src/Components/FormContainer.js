import React, { useState } from "react";

export default function FormContainer({ onLoginSuccess }) {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");

  const handleLogin = async (e) => {
    e.preventDefault();

    try {
      const response = await fetch("https://localhost:7294/api/auth/login", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ username, password }),
      });

      if (!response.ok) {
        alert("Invalid username or password");
        return;
      }

      const data = await response.json();

      // Save token
      localStorage.setItem("token", data.token);

      onLoginSuccess();
    } catch (error) {
      console.error("Login error:", error);
      alert("Failed to connect to API!");
    }
  };

  return (
    <form
      onSubmit={handleLogin}
      style={{ width: "300px", margin: " auto", marginTop: "30px" }}
    >
      <div>
        <label>Username:</label>
        <input
          type="text"
          value={username}
          onChange={(e) => setUsername(e.target.value)}
          required
        />
      </div>

      <div style={{ marginTop: "10px" }}>
        <label>Password:</label>
        <input
          type="password"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
          required
        />
      </div>

      <button
        type="submit"
        style={{
          marginTop: "15px",
          width: "100%",
          padding: "10px",
          backgroundColor: "#007bff",
          color: "white",
          border: "none",
          borderRadius: "5px",
        }}
      >
        Login
      </button>
    </form>
  );
}
