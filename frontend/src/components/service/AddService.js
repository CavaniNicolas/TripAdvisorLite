
import { useState, useEffect } from 'react';
import TypeOption from './TypeOption';

function AddService() {

    const [serviceData, setServiceData] = useState([]);
	useEffect(() => 
	  fetch("https://localhost:44398/services")
		.then(response => response.json())
		.then(json => setServiceData(json))
	  ,[]);
  
    let MaxId = -1;
    serviceData.forEach(service => {
        if(service.serviceId > MaxId)
            MaxId = service.serviceId;
    });
    MaxId = MaxId + 1;   

    let OptionListTypes = serviceData.map(service => <TypeOption Type={service.type} key={service.serviceId}/>);
	let uniqueTypes = []
	let uniqueOptionTypes = []
	OptionListTypes.forEach(OptionType => {
		if (!uniqueTypes.includes(OptionType.props.Type)){
			uniqueTypes.push(OptionType.props.Type);
			uniqueOptionTypes.push(OptionType);
		}
	});

    const SubmitFunction = (name,adress,type) => {
        if(name != null && adress!=null && type !=null){
            fetch("https://localhost:44398/insertservice?id="+MaxId+"&name="+name+"&adress="+adress+"&type="+type);
        }
    }
    
    const [timer, setTimer] = useState(null);
    const [previousText, setPreviousText] = useState(null);

    const [name, setName] = useState(null);
    const [adress, setAdress] = useState(null);
    const [type, setType] = useState(null);

	return (
        <div>
            <div>
				<label for="exampleDataList" className="form-label">Name</label>
				<input className="form-control" id="ListName"
				onChange={e => setName(e.target.value)}/>
        	</div>

            <div>
				<label for="exampleDataList" className="form-label">Adress</label>
				<input className="form-control" id="ListAdress"
				onChange={e => setAdress(e.target.value)}/>
        	</div>

            <div>
				<label for="exampleDataList" className="form-label">Service category</label>
				<input className="form-control" list="datalistOptions" id="ListType"
				onChange={e => setType(e.target.value)}/>
                <datalist id="datalistOptions">
					{uniqueOptionTypes}
				</datalist>
        	</div><br/>

            <button class="btn btn-primary" onClick = {() => SubmitFunction(name,adress,type)}> Submit Service </button>
        </div>
	);
}
export default AddService;