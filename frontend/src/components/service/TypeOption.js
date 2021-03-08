import './Option.css';
import 'bootstrap/dist/css/bootstrap.css';

function TypeOption({Type}) {
    return (<option value={Type}>{Type}</option>);
}

export default TypeOption;