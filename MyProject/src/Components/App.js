import React, { useState } from "react";

function App() {
  // Data
  const people = [
    { name: "Alice", profession: "Physicist" },
    { name: "Bob", profession: "Mathematician" },
    { name: "Carol", profession: "Chemist" },
    { name: "Dave", profession: "Computer Scientist" },
    { name: "Eve", profession: "Biologist" },
    { name: "Frank", profession: "Physicist" },
  ];

  const professions = [
    "All",
    "Physicist",
    "Mathematician",
    "Chemist",
    "Computer Scientist",
    "Biologist",
  ];

  // State
  const [selectedProfession, setSelectedProfession] = useState("All");

  // Filter logic
  const filteredPeople =
    selectedProfession === "All"
      ? people
      : people.filter((p) => p.profession === selectedProfession);

  return (
    <div>
      <h1>Profession Filter</h1>

      {/* Filter buttons */}
      <div>
        {professions.map((profession) => (
          <button
            key={profession}
            onClick={() => setSelectedProfession(profession)}
          >
            {profession}
          </button>
        ))}
      </div>

      {/* Filtered people list */}
      <ul>
        {filteredPeople.length === 0 ? (
          <li>No results found.</li>
        ) : (
          filteredPeople.map((person) => (
            <li key={person.name}>
              {person.name} — {person.profession}
            </li>
          ))
        )}
      </ul>
    </div>
  );
}

export default App;
