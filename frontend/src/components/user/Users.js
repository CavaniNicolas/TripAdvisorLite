
import { useState, useEffect } from 'react';
import User from './User.js'

function Users() {

	const [userData, setUserData] = useState([]);
	useEffect(() => 
	  fetch((window.location.href).replace('3000','44398').replace('http','https'))
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
		  <div className="col-1">nb_reviews</div>
		  <h1> </h1>
		  {UserList}
        </div>
    );
}
export default Users;