import React, { useEffect, useState } from "react";

function Dashboard({ onLogout }) {
  const [profile, setProfile] = useState(null);

  useEffect(() => {
    const token = localStorage.getItem("token");

    if (!token) {
      alert("You must login first!");
      onLogout();
      return;
    }

    fetch("https://localhost:7294/api/auth/profile", {
      headers: {
        Authorization: `Bearer ${token}`,
        "Content-Type": "application/json",
      },
    })
      .then(async (res) => {
        if (res.status === 401) {
          alert("Session expired! Please login again.");
          localStorage.removeItem("token");
          onLogout();
          return;
        }

        const data = await res.json();
        setProfile(data);
      })
      .catch((err) => console.error("Error fetching profile:", err));
  }, []);

  if (!profile) return <h3>Loading profile...</h3>;

  return (
    <div style={{ textAlign: "center" }}>
      <h2>Welcome, {profile.fullName}</h2>
      <p><b>Email:</b> {profile.email}</p>
      <p><b>Username:</b> {profile.username}</p>
      <p><b>Joined:</b> {new Date(profile.createdDate).toLocaleDateString()}</p>

      <button
        onClick={() => {
          localStorage.removeItem("token");
          onLogout();
        }}
        style={{
          marginTop: "25px",
          padding: "10px 20px",
          backgroundColor: "#ff4d4d",
          color: "white",
          border: "none",
          borderRadius: "5px",
          cursor: "pointer",
        }}
      >
        Logout
      </button>
    </div>
  );
}

export default Dashboard;
