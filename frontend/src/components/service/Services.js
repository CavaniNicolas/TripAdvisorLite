
import './Service.css';
import { useState, useEffect } from 'react';
import Service from './Service.js'
import Option from './Option';

function Services() {

	const [serviceData, setServiceData] = useState([]);
	useEffect(() => 
	  fetch((window.location.href).replace('3000','44398').replace('http','https'))
		.then(response => response.json())
		.then(json => setServiceData(json))
	  ,[]);
  
	let ServiceList = serviceData.map(service => <Service id={service.serviceId} name={service.name} adress={service.adress}
	  key={service.serviceId}
	/>);

	const [timer, setTimer] = useState(null);
	const [previousText, setPreviousText] = useState(null);

	let OptionList = serviceData.map(service => <Option Name={service.name} key={service.serviceId}/>);

  	const SearchbarFunction = txt => {
                                fetch('https://localhost:44398/services?name='+txt)
                                  .then(response => response.json())
								  .then(json =>	setServiceData(json)
								  );
	}

	//lodash
	const Sorter = (ServiceA, ServiceB) => {
		if(menuClicked === 'name'){
			return (ServiceA.name.localeCompare(ServiceB.name));
		}
		if(menuClicked === 'id'){
			return (ServiceA.id > ServiceB.id);
		}
		if(menuClicked === 'adress'){
			return (ServiceA.adress.localeCompare(ServiceB.adress));
		}
	}

	const [menuClicked, setMenuClicked] = useState(null);
  	async function ClickSort (what){
		setMenuClicked(what);
		console.log(menuClicked);
		setServiceData(await serviceData.sort(Sorter));
  	}

	return (
		<div className="row">
		  	<h1>services</h1>

		  	<div className="country-search">
				<div className="search-bar">
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
				</div>
				<datalist id="datalistOptions">
					{OptionList}
				</datalist>
        	</div>

			<div className="col-1" onClick={() => ClickSort('id') }>serviceid</div>
			<div className="col-2" onClick={() => ClickSort('name') }>name</div>
			<div className="col-3" onClick={() => ClickSort('adress') }>adress</div>
			<div className="col-4" onClick={() => ClickSort('note') }>note</div>
			<h1> </h1>
			{ServiceList}
        </div>
	);
}
export default Services;