import React from "react";
import FormContainer from "./FormContainer";

export default function Login({ onLoginSuccess }) {
  return (
    <div>
      <h2 style={{ textAlign: "center", marginTop: "20px" }}>Login Page</h2>
      <FormContainer onLoginSuccess={onLoginSuccess} />
    </div>
  );
}
