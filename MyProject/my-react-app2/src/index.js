import React from 'react';
import ReactDOM from 'react-dom/client';
/* import './index.css';
import App from './App'; */
import reportWebVitals from './reportWebVitals';
/* import WelcomePage from './Components/welcome';
import PersonDetails from './Components/PersonDetails';
import { people } from './Components/person';
import Mainapp from './Components/Mainapp';
import FIX_ERROR_02 from './Components/FIX_ERROR_02';
import Forms from './Components/Forms';
import Time from './Components/TimeSelector'; */
import { Provider } from 'react-redux';
import { store } from './Components/store';
/* import FormContainer from './Components/FormContainer';  */
import Child from './Components/Child';
import { BrowserRouter } from "react-router-dom";
import Navigation from './Components/Route';



const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    {/* <App/> */}
    <Provider store={store}>
    <BrowserRouter>
<Navigation/>
</BrowserRouter>
 {/*  <FormContainer/>  */}
    <Child/>
      </Provider>
   {/*  <Forms/>
    <Time/>
    <FIX_ERROR_02/>
<Mainapp/>
    <WelcomePage/>
    <PersonDetails people={people} /> */}
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
