import React, { useState, useEffect } from 'react';
import Sessions from "./Sessions";
import './App.css';

function App() {
    const [ sessions, setSessions ] = useState();
    async function initSessions() {
        const data = await fetch("https://localhost:5001/LoginMonitor", {
            headers: { accepts: "application/json" }
        }).then(res => res.json());
        console.log(data);
        setSessions(data);
    }
    useEffect(() => { initSessions(); }, []);
    return (sessions && sessions.length)
        ? <Sessions sessions={sessions} />
        : <div>Loading...</div>
};

export default App;
