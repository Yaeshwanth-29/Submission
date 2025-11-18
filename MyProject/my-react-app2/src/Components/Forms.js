import React, { useState } from "react";

const namefields = {
  Username: "Username",
  Label: "Name",
  Placeholder: "Enter your name",
};

const emailfields = {
  Email: "Email",
  Label: "Mail",
  Placeholder: "Enter your email",
};

const passwordfields = {
  Password: "Password",
  Label: "Secret Key",
  Placeholder: "Password please",
};

function Userform() {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [submitted, setSubmitted] = useState(false);

  // Handle Submit
  const handleSubmit = (e) => {
    e.preventDefault();
    setSubmitted(true);
  };

  // Handle Clear
  const handleClear = () => {
    setName("");
    setEmail("");
    setPassword("");
    setSubmitted(false);
  };

  return (
    <div
      className="mass"
      style={{
        textAlign: "center",
        marginTop: "50px",
        color: "blueviolet",
        fontFamily: "Arial, sans-serif",
      }}
    >
      <h2>User Form</h2>

      <form
        onSubmit={handleSubmit}
        style={{
          display: "inline-block",
          textAlign: "left",
          backgroundColor: "#f9f9f9",
          padding: "20px",
          borderRadius: "10px",
          boxShadow: "0 0 10px rgba(0,0,0,0.1)",
        }}
      >
        {/* Name Field */}
        <div style={{ marginBottom: "15px" }}>
          <label style={{ display: "block", marginBottom: "5px" }}>
            {namefields.Label}:
          </label>
          <input
            type="text"
            placeholder={namefields.Placeholder}
            value={name}
            onChange={(e) => setName(e.target.value)}
            style={{
              padding: "8px",
              width: "250px",
              borderRadius: "5px",
              border: "1px solid #ccc",
            }}
          />
        </div>

        {/* Email Field */}
        <div style={{ marginBottom: "15px" }}>
          <label style={{ display: "block", marginBottom: "5px" }}>
            {emailfields.Label}:
          </label>
          <input
            type="email"
            placeholder={emailfields.Placeholder}
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            style={{
              padding: "8px",
              width: "250px",
              borderRadius: "5px",
              border: "1px solid #ccc",
            }}
          />
        </div>

        {/* Password Field */}
        <div style={{ marginBottom: "15px" }}>
          <label style={{ display: "block", marginBottom: "5px" }}>
            {passwordfields.Label}:
          </label>
          <input
            type="password"
            placeholder={passwordfields.Placeholder}
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            style={{
              padding: "8px",
              width: "250px",
              borderRadius: "5px",
              border: "1px solid #ccc",
            }}
          />
        </div>

        {/* Buttons */}
        <div style={{ textAlign: "center" }}>
          <button
            type="submit"
            style={{
              backgroundColor: "blueviolet",
              color: "white",
              border: "none",
              padding: "10px 20px",
              borderRadius: "5px",
              cursor: "pointer",
              marginRight: "10px",
            }}
          >
            Submit
          </button>

          <button
            type="button"
            onClick={handleClear}
            style={{
              backgroundColor: "gray",
              color: "white",
              border: "none",
              padding: "10px 20px",
              borderRadius: "5px",
              cursor: "pointer",
            }}
          >
            Clear
          </button>
        </div>
      </form>
<br/>
      {/* Output Section */}
      <div
        style={{
          marginTop: "30px",
          backgroundColor: "pink",
          padding: "15px",
          borderRadius: "10px",
          display: "wrap",
        }}
      >
        <h3>Form Output:</h3>
        <p>
          <strong>Name:</strong> {submitted ? name || "No name provided" : "Not filled"}
        </p>
        <p>
          <strong>Email:</strong> {submitted ? email || "No email provided" : "Not filled"}
        </p>
        <p>
          <strong>Password:</strong> {submitted ? password || "No password provided" : "Not filled"}
        </p>
      </div>
    </div>
  );
}

export default Userform;
