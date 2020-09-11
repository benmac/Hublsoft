import React, { useState, useEffect } from 'react';
import Sessions from "./Sessions";
import './App.css';

function App() {
    const [ sessions, setSessions ] = useState([]);
    useEffect(() => {
        setSessions([{
            id: 1,
            timeStamp: "2020-09-09T23:46:27.1129587",
            userId: "agibson@hublsoft.com"
        }])
    },[])
    return <Sessions sessions={sessions} />
};

export default App;
