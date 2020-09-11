import React from "react";

const Session = (session) => <tr>
    <td>{session.userId}</td>
    <td>{session.timeStamp}</td>
</tr>;

const Sessions = ({ sessions }) => <table>
    <thead>
        <th>UserId</th>
        <th>TimeStamp</th>
    </thead>
    <tbody>
        {sessions.map(Session)}
    </tbody>
</table>;

export default Sessions;