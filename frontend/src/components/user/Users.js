
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

	const [menuClicked, setMenuClicked] = useState(null);
  	function ClickSort (what){
		const Sorter = (UserA, UserB) => {
			if(what === 'name'){
				return (UserA.username.localeCompare(UserB.username));
			}
			if(what === 'id'){
				return (UserA.userId - UserB.userId);
			}
			if(what === 'nb'){
				console.log('todo');
				return (1);
			}
		}
		setMenuClicked(what);
		setUserData(userData.sort(Sorter));
	  }
	  
	function Arrow (what){
		if (what === menuClicked){
			return ' v';
		}
	}

    return (
		<div className="row">
		  <h1>users</h1>
          <div className="col-2"onClick={() => ClickSort('id') }>userid{Arrow('id')}</div>
          <div className="col-2"onClick={() => ClickSort('name') }>username{Arrow('name')}</div>
		  <div className="col-2"onClick={() => ClickSort('nb') }>nb_reviews{Arrow('nb')}</div>
		  <h1> </h1>
		  {UserList}
        </div>
    );
}
export default Users;