
import { useState, useEffect } from 'react';
import Service from './Service.js'
import Option from './Option';
import TypeOption from './TypeOption';

function Services() {

	const [serviceData, setServiceData] = useState([]);
	useEffect(() => 
	  fetch((window.location.href).replace('3000','44398').replace('http','https'))
		.then(response => response.json())
		.then(json => setServiceData(json))
	  ,[]);
  
	let ServiceList = serviceData.map(service => <Service id={service.serviceId} name={service.name} adress={service.adress} type={service.type}
	  key={service.serviceId}
	/>);

	const [timer, setTimer] = useState(null);
	const [previousText, setPreviousText] = useState(null);

	let OptionList = serviceData.map(service => <Option Name={service.name} key={service.serviceId}/>);
	
	const [AllData, setAllData] = useState([]);
	useEffect(() => 
	  fetch("https://localhost:44398/services")
		.then(response => response.json())
		.then(json => setAllData(json))
	  ,[]);
	let OptionListTypes = AllData.map(service => <TypeOption Type={service.type} key={service.serviceId}/>);
	let uniqueTypes = []
	let uniqueOptionTypes = []
	OptionListTypes.forEach(OptionType => {
		if (!uniqueTypes.includes(OptionType.props.Type)){
			uniqueTypes.push(OptionType.props.Type);
			uniqueOptionTypes.push(OptionType);
		}
	});

	const [c_name, setCName] = useState(null);
	const [c_type, setCType] = useState(null);
	const queryString = (name, type) => {return`${name?'name='+name:''}${type?'&type='+type:''}`;};
	
  	const SearchbarFunction = txt => {
		fetch('https://localhost:44398/services?'+queryString(txt,c_type))
			.then(response => response.json())
			.then(json =>	setServiceData(json)
			);
		setCName(txt);
	}
	
	const SelectFunction = type => {
		fetch('https://localhost:44398/services?'+queryString(c_name,type))
		  .then(response => response.json())
		  .then(json =>	setServiceData(json)
		  );
		setCType(type);
}

	//lodash
	

	const [menuClicked, setMenuClicked] = useState(null);
  	function ClickSort (what){
		const Sorter = (ServiceA, ServiceB) => {
			if(what === 'name'){
				return (ServiceA.name.localeCompare(ServiceB.name));
			}
			if(what === 'id'){
				return (ServiceA.serviceId.toString().localeCompare(ServiceB.serviceId.toString()));
			}
			if(what === 'adress'){
				return (ServiceA.adress.localeCompare(ServiceB.adress));
			}
			if(what === 'note'){
				console.log('todo');
				return (1);
			}
			if(what === 'type'){
				return (ServiceA.type.localeCompare(ServiceB.type));
			}
		}
		setMenuClicked(what);
		setServiceData(serviceData.sort(Sorter));
	  }
	  
	function Arrow (what){
		if (what === menuClicked){
			return ' v';
		}
	}

	return (
		<div className="row">
		  	<h1>services</h1>

		  	<div className="name-search">
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

			<div className="type-select">
			<label for="exampleDataList" className="form-label">Select a service type</label>
				<select className="selectpicker" aria-label=".form-select-lg example" onChange={e => SelectFunction(e.target.value)}>
					{uniqueOptionTypes}
				</select>
			</div>

			<div className="col-1" onClick={() => ClickSort('id') }>serviceid{Arrow('id')}</div>
			<div className="col-2" onClick={() => ClickSort('name') }>name{Arrow('name')}</div>
			<div className="col-3" onClick={() => ClickSort('adress') }>adress{Arrow('adress')}</div>
			<div className="col-2" onClick={() => ClickSort('type') }>type{Arrow('type')}</div>
			<div className="col-1" onClick={() => ClickSort('note') }>note{Arrow('note')}</div>
			<h1> </h1>
			{ServiceList}
        </div>
	);
}
export default Services;