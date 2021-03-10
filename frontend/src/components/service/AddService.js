
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

    const SubmitFunction = (f_name,f_adress,f_type) => {
        if(f_name != null && f_adress!=null && f_type !=null){
			fetch("https://localhost:44398/insertservice?id="+MaxId+"&name="+f_name+"&adress="+f_adress+"&type="+f_type);
			window.alert("Service successfully added!");
		}
		else{
			window.alert("Error: please fill all the fields");
		}
    }

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