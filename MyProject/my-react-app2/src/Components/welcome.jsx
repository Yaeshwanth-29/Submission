import React from 'react';
 
function WelcomePage() {
  return (
    <div className="welcome-container"
    style={{
        color: 'darkblue',
        display: 'flex',
        backgroundColor: 'palegreen',
        textAlign: 'center'
    }
    }
    
    >
      <h1 style={{textAlign:'center', marginTop: '30px', color: 'blue'}} >Hey Everybody</h1>
      <p style={{textAlign:'center', marginTop: '20px', display:'inline'}}>We are doing our first react app</p>
      <form className="form">
        <input style ={{textAlign:'center', alignContent:'center'}}type="text" />
        <button type="submit">Submit</button>
        <input type="text"/>
        <button type="text">clear</button>
        
      </form>
    </div>

  );
}
 
export default WelcomePage;