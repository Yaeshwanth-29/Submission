import React from "react";
import { NavLink } from "react-router-dom";

export default function Navbar() {
  const baseLinkStyle = {
    margin: "0 12px",
    textDecoration: "none",
    color: "#f8f9fa",
    fontWeight: "600",
    fontSize: "16px",
    padding: "8px 14px",
    borderRadius: "6px",
    transition: "all 0.3s ease",
  };

  const getActiveStyle = ({ isActive }) => ({
    ...baseLinkStyle,
    backgroundColor: isActive ? "#fff" : "transparent",
    color: isActive ? "#007bff" : "#f8f9fa",
    boxShadow: isActive ? "0 2px 8px rgba(255,255,255,0.4)" : "none",
  });

  return (
    <nav
      style={{
        background: "linear-gradient(90deg, #007bff, #6610f2)",
        padding: "15px 30px",
        display: "flex",
        justifyContent: "space-between",
        alignItems: "center",
        boxShadow: "0 4px 10px rgba(0, 0, 0, 0.2)",
        position: "sticky",
        top: "0",
        zIndex: "999",
      }}
    >
      {/* 🌟 Brand Logo */}
      <div
        style={{
          fontWeight: "700",
          fontSize: "22px",
          color: "#fff",
          letterSpacing: "1px",
          display: "flex",
          alignItems: "center",
          gap: "8px",
        }}
      >
        🚀 <span>MyReactApp</span>
      </div>

      {/* 🌈 Center Navigation Links */}
      <div style={{ display: "flex", alignItems: "center" }}>
        <NavLink to="/home" style={getActiveStyle}>
          Home
        </NavLink>
        <NavLink to="/about" style={getActiveStyle}>
          About
        </NavLink>
        <NavLink to="/contact" style={getActiveStyle}>
          Contact
        </NavLink>
        <NavLink to="/myapp" style={getActiveStyle}>
          MyApp
        </NavLink>
        <NavLink to="/users" style={linkStyle}>
  Users
</NavLink>

      </div>

      {/* 🔍 Right Side - Search & Login */}
      <div style={{ display: "flex", alignItems: "center", gap: "15px" }}>
        {/* Search Bar */}
        <input
          type="text"
          placeholder="Search..."
          style={{
            padding: "6px 12px",
            borderRadius: "20px",
            border: "none",
            outline: "none",
            backgroundColor: "rgba(255, 255, 255, 0.2)",
            color: "#fff",
            fontSize: "14px",
            width: "150px",
            transition: "width 0.3s ease, background 0.3s ease",
          }}
          onFocus={(e) => (e.target.style.width = "200px")}
          onBlur={(e) => (e.target.style.width = "150px")}
        />

        {/* Login Button */}
        <NavLink
          to="/login"
          style={({ isActive }) => ({
            ...baseLinkStyle,
            backgroundColor: isActive ? "#28a745" : "#ffc107",
            color: isActive ? "#fff" : "#000",
            fontWeight: "700",
            padding: "8px 18px",
            borderRadius: "25px",
            boxShadow: isActive
              ? "0px 4px 10px rgba(40,167,69,0.4)"
              : "0px 4px 10px rgba(255,193,7,0.5)",
          })}
        >
          Login
        </NavLink>
      </div>
    </nav>
  );
}
