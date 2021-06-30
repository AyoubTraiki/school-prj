import React from 'react'
function Etudiant(props) {
    return (
        <fieldset className="etudiant">
        <div>
        
            <label>Nom:         {props.nom}</label><br/><br/>
            <label>Prenom:      {props.prenom}</label><br/><br/>
            <label>             {checkfiliere(props.filiere)}</label><br/>
            
           
        
        </div>
        </fieldset>
    )
}
let checkfiliere=(filiere)=>{
    if(filiere){
        return <label>Filiere: {filiere}</label>
    }
    else{
        return <label>filiere : Pas de données</label>
    }
    

}


export default Etudiant;
