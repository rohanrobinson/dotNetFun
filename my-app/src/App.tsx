import React, { useState, useEffect } from 'react';
import logo from './logo.svg';
import './App.css';

function App() {

  const [message, setMessage] = useState('');
  const [anotherMessage, setAnotherMessage] = useState('');

  useEffect(()=> {
    fetch('http://localhost:5062/data')
    .then(response => response.json())
    .then(data => setMessage(data.message))
    .catch(error => console.error('Error:', error));
  }, []);

  useEffect(() => {
    fetch('http://localhost:5062/moreData')
    .then(response => response.json())
    .then(data => setAnotherMessage(data.message))
    .catch(error => console.error('Error:', error));
  }, []);



  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
            {message || 'first message loading...'}
        </p> <br />
        <p>
            {anotherMessage || 'second message loading...'}
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
