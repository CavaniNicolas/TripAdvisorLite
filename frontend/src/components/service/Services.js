
import { useState, useEffect } from 'react';
import Service from './Service.js'

function Services() {

	const [serviceData, setServiceData] = useState([]);
	useEffect(() => 
	  fetch('https://localhost:44398/services')
		.then(response => response.json())
		.then(json => setServiceData(json))
	  ,[]);
  
	let ServiceList = serviceData.map(service => <Service id={service.serviceId} name={service.name} adress={service.adress}
	  key={service.serviceId}
	/>);

	return (
		<div className="row">
		  <h1>services</h1>
          <div className="col-1">serviceid</div>
          <div className="col-1">name</div>
          <div className="col-4">adress</div>
          <h1> </h1>
          {ServiceList}
        </div>
	);
}
export default Services;