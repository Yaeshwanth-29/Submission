import React, { useState } from "react";
import Login from "./Login";
import Dashboard from "./Dashboard";

function logging() {
  const [isLoggedIn, setIsLoggedIn] = useState(
    !!localStorage.getItem("token")
  );

  return isLoggedIn ? (
    <Dashboard onLogout={() => setIsLoggedIn(false)} />
  ) : (
    <Login onLoginSuccess={() => setIsLoggedIn(true)} />
  );
}

export default logging;
