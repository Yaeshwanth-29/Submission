import React from "react";

const baseUrl = 'https://i.imgur.com/7dQD0fP.jpg';
const person = {
  name: 'Gregorio Y. Zare',
  imageId: '7dQD0fP',
  imageSize: 's', 
  theme: {
    backgroundColor: 'black',
    color: 'pink',
    padding: '20px',
    textAlign: 'center',
  },
};

const a = baseUrl + person.imageId + person.imageSize + ".jpg";

export default function FIX_ERROR_02() {
  return (
    <div style={person.theme}>
      <h1>{person.name}'s Todos</h1>
      <img
        className="avatar"
        src={a}
        alt={person.name}
        style={{
          borderRadius: "50%",
          marginTop: "10px",
          width: "150px",
          height: "150px",
        }}
      />
    </div>
  );
}
