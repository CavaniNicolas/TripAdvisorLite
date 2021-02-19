
import { useState, useEffect } from 'react';
import User from './User.js'

function Users() {

	const [userData, setUserData] = useState([]);
	useEffect(() => 
	  fetch('https://localhost:44398/users')
		.then(response => response.json())
		.then(json => setUserData(json))
	  ,[]);
  
	let UserList = userData.map(user => <User id={user.userId} name={user.username} 
	  key={user.userId}
	/>);

    return (
		<div className="row">
		  <h1>users</h1>
          <div className="col-1">userid</div>
          <div className="col-1">username</div>
		  <h1> </h1>
		  {UserList}
        </div>
    );
}
export default Users;