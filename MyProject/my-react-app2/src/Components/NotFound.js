import React from "react";
import { Link } from "react-router-dom";

export default function NotFound() {
  return (
    <div
      style={{
        textAlign: "center",
        marginTop: "100px",
      }}
    >
      <h1 style={{ fontSize: "60px", color: "#ff4d4f" }}>404</h1>
      <h2>Page Not Found</h2>
      <p>Sorry, the page you’re looking for doesn’t exist.</p>
      <Link
        to="/myapp"
        style={{
          color: "#007bff",
          textDecoration: "none",
          fontWeight: "bold",
        }}
      >
        Go Back to MyApp
      </Link>
    </div>
  );
}
