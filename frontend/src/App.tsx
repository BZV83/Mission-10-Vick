import React from 'react';
import logo from './logo.svg';
import './App.css';
import Header from './header';
import BowlerList from './Bowlers/BowlerList';

function App() {
  return (
    <div className="App">
      <Header title="Best City Bowlers" />
      <BowlerList />
    </div>
  );
}

export default App;
