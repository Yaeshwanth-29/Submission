import React, { useEffect, useState } from "react";
import { useSelector } from "react-redux";

export default function FetchUsers() {
  const [users, setUsers] = useState([]);
  const [loading, setLoading] = useState(false);
  const submitted = useSelector((state) => state.form.submitted);

  useEffect(() => {
    if (submitted) {
      setLoading(true);
      fetch("https://jsonplaceholder.typicode.com/users")
        .then((res) => res.json())
        .then((data) => {
          setUsers(data);
          setLoading(false);
        })
        .catch((error) => {
          console.error("Fetch error:", error);
          setLoading(false);
        });
    }
  }, [submitted]);

  if (!submitted) {
    return <h3 style={{ textAlign: "center" }}>Please login first.</h3>;
  }

  if (loading) return <h3 style={{ textAlign: "center" }}>Loading data...</h3>;

  return (
    <div style={{ padding: "20px" }}>
      <h2 style={{ textAlign: "center", color: "#007bff" }}>Fetched User Data</h2>
      <ul style={{ listStyle: "none", padding: 0 }}>
        {users.map((user) => (
          <li
            key={user.id}
            style={{
              background: "#f9f9f9",
              margin: "10px 0",
              padding: "10px",
              borderRadius: "8px",
              boxShadow: "0 1px 3px rgba(0,0,0,0.1)",
            }}
          >
            <strong>{user.name}</strong> — {user.email}
          </li>
        ))}
      </ul>
    </div>
  );
}
