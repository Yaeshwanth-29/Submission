// src/FormComponent.js
import React from 'react';

export default function FormComponent({ username, email, password, handleChange, handleSubmit, handleReset }) {
  return (
    <div style={{
      border: "2px solid #ccc",
      padding: "20px",
      width: "300px",
      margin: "auto",
      borderRadius: "10px",
      backgroundColor: "#f8f8f8"
    }}>
      <h2 style={{ color: "red", textAlign: "center" }}>Form Container (Redux)</h2>

      <label style={{textAlign: 'left'}}>Username:</label>
      <input
        type="text"
        name="username"
        placeholder='Enter Your Name'
        value={username}
        onChange={handleChange}
        style={{ width: "100%", marginBottom: "10px", textAlign:'left' }}
      />

      <label>Email:</label>
      <input
        type="email"
        name="email"
        placeholder='Enter Your Mail-ID'
        value={email}
        onChange={handleChange}
        style={{ width: "100%", marginBottom: "10px" }}
      />

      <label>Password:</label>
      <input
        type="password"
        name="password"
        placeholder='Enter Your Secret Key'
        value={password}
        onChange={handleChange}
        style={{ width: "100%", marginBottom: "15px" }}
      />

      <div style={{ display: "flex", justifyContent: "space-between" }}>
        <button onClick={handleSubmit} style={{ background: "green", color: "white", padding: "5px 10px", border: "none", borderRadius: "5px" }}>Login</button>
        <button onClick={handleReset} style={{ background: "red", color: "white", padding: "5px 10px", border: "none", borderRadius: "5px" }}>Reset</button>
      </div>
    </div>
  );
}
