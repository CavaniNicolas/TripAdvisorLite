
import { useState, useEffect } from 'react';
import Service from './Service.js'
import Option from './Option';

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

	const [timer, setTimer] = useState(null);
	const [previousText, setPreviousText] = useState(null);

	let OptionList = serviceData.map(service => <Option Name={service.name} key={service.serviceId}/>);
	
	const [searchText, setSearchText] = useState(null);
  	const SearchbarFunction = txt => {
                                fetch('https://localhost:44398/services?name='+txt)
                                  .then(response => response.json())
								  .then(json => setServiceData(json));
  	}

	return (
		<div className="row">
		  	<h1>services</h1>

		  	<div className="country-search">
				<label for="exampleDataList" className="form-label">Search by name</label>
				<input className="form-control" list="datalistOptions" id="exampleDataList" placeholder="Type to search..."
				onChange={e => {
					if (previousText !== e.target.value) {
						clearTimeout(timer);
						const timeoutId = setTimeout(() => SearchbarFunction(e.target.value), 1000);
						setTimer(timeoutId);
						setPreviousText(e.target.value);
					}
					}}/>
				<datalist id="datalistOptions">
					{OptionList}
				</datalist>
        	</div>

			<div className="col-1">serviceid</div>
			<div className="col-2">name</div>
			<div className="col-3">adress</div>
			<div className="col-2">Click to view reviews</div>
			<h1> </h1>
			{ServiceList}
        </div>
	);
}
export default Services;