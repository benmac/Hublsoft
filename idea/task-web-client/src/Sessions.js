import React from "react";

const formatDate = x => `
    ${Intl.DateTimeFormat("en", { year: "numeric", month: "2-digit", day: "2-digit" }).format(new Date(x))}
    ${Intl.DateTimeFormat("en", { hour: "numeric", minute: "numeric", second: "numeric", hour12: false}).format(new Date(x))}
`;

const Session = (session) => <tr>
    <td>{session.userId}</td>
    <td>{formatDate(session.timeStamp)}</td>
</tr>;

const Sessions = ({ sessions }) => <table class="table">
    <thead>
        <th>UserId</th>
        <th>TimeStamp</th>
    </thead>
    <tbody>
        {sessions.map(Session)}
    </tbody>
</table>;

export default Sessions;