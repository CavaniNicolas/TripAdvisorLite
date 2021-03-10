
import './Service.css';
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

	const [menuClicked, setMenuClicked] = useState(null);
  	function ClickSort (what){
		const Sorter = (ServiceA, ServiceB) => {
			if(what === 'name'){
				return (ServiceA.name.localeCompare(ServiceB.name));
			}
			if(what === 'id'){
				return (ServiceA.serviceId - ServiceB.serviceId);
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

	const [userData, setUserData] = useState([]);
	useEffect(() => 
	  fetch("https://localhost:44398/users")
		.then(response => response.json())
		.then(json => setUserData(json))
	,[]);
  
    let MaxUserId = 0;
    userData.forEach(user => {
        if(user.userId > MaxUserId)
            MaxUserId = user.userId;
    });
    MaxUserId = MaxUserId + 1;  
	let userId = -1;

	const [reviewData, setReviewData] = useState([]);
	useEffect(() => 
	  fetch("https://localhost:44398/reviews")
		.then(response => response.json())
		.then(json => setReviewData(json))
	  ,[]);
  
    let MaxId = 0;
    reviewData.forEach(review => {
        if(review.reviewId > MaxId)
            MaxId = review.reviewId;
    });
    MaxId = MaxId + 1;  

	var today = new Date();
	var dd = String(today.getDate()).padStart(2, '0');
	var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
	var yyyy = today.getFullYear();
	today = dd + '/' + mm + '/' + yyyy;

	const [note, setNote] = useState(null);
	const [userName, setUserName] = useState(null);
    const [text, setText] = useState(null);
	
	const SubmitFunction = (f_note,f_username,f_text) => {
        if(f_note != null && f_username!=null && f_text !=null){
			userData.forEach(user => {
				if(user.username === f_username)
					userId = user.userId;
			});
			if (userId === -1){
				fetch("https://localhost:44398/insertuser?id="+MaxUserId+"&name="+f_username);
				userId = MaxUserId;
			}
			setTimeout(() => fetch("https://localhost:44398/insertreview?id="+MaxId+"&userid="+userId+"&serviceid="+serviceData[0].serviceId+"&note="+f_note+"&texte="+f_text+"&date="+today), 1000);
			window.alert("Review successfully added!");
		}
		else{
			window.alert("Error: please fill all the fields");
		}
    }

	function AddReview (){
		if (serviceData.length===1){
			return (
			<div>
				<h5>Leave a review for this service</h5>	
				<div className="tom-form">
					<div>
						<label className="form-label">Username</label><br></br>
						<input id="ListName" className="textarea" onChange={e => setUserName(e.target.value)}/>
					</div>

					<div>
						<label className="form-label">Note</label><br></br>
						<select class="form-control form-control-sm" onChange={e => setNote(e.target.value)}>
							<option>1</option>
							<option>2</option>
							<option>3</option>
							<option>4</option>
							<option>5</option>
						</select>
					</div>

					<div>
						<label className="form-label">Comment</label><br></br>
						<textarea name="comment" onChange={e => setText(e.target.value)}></textarea>
					</div>

					<button class="btn btn-primary" onClick = {() => SubmitFunction(note,userName,text)}> Submit review </button>
				</div>
			</div>); 
		}
		else return(<div></div>);
	}

	return (
		<div>
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

				<div className="type-select">
				<label for="exampleDataList" className="form-label">Select a service type</label>
					<select className="selectpicker" aria-label=".form-select-lg example" onChange={e => SelectFunction(e.target.value)}>
						{uniqueOptionTypes}
					</select>
				</div>

				<div className="col-1" onClick={() => ClickSort('id') }>serviceid{Arrow('id')}</div>
				<div className="col-3" onClick={() => ClickSort('name') }>name{Arrow('name')}</div>
				<div className="col-3" onClick={() => ClickSort('adress') }>adress{Arrow('adress')}</div>
				<div className="col-2" onClick={() => ClickSort('type') }>type{Arrow('type')}</div>
				<div className="col-1" onClick={() => ClickSort('note') }>note{Arrow('note')}</div>

				<h1> </h1>
				{ServiceList}
			</div>
			<div>
				{AddReview()}
			</div>
		</div>
		
	);
}
export default Services;