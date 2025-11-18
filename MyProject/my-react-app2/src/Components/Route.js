import React from "react";
import { Routes, Route, Navigate } from "react-router-dom";
import Navbar from "./Navbar";
import Home from "./Home";
import About from "./About";
import Contact from "./Contact";
import MyApp from "./MyApp";
import NotFound from "./NotFound";
import Login from "./Login"; 
import FetchUsers from "./FetchUsers";

export default function Navigation() {
  return (
    <div>
      <Navbar />
      <div style={{ padding: "20px" }}>
        <Routes>
          <Route path="/" element={<Navigate to="/myapp" replace />} />
          <Route path="/home" element={<Home />} />
          <Route path="/about" element={<About />} />
          <Route path="/contact" element={<Contact />} />
          <Route path="/myapp" element={<MyApp />} />
          <Route path="/login" element={<Login />} /> 
          <Route path="/users" element={<FetchUsers />} />
          <Route path="*" element={<NotFound />} />
        </Routes>
      </div>
    </div>
  );
}
