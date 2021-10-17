import { Component, OnInit } from '@angular/core';
import { Customers } from '../../models/customers';
import { ServiceNorthwind } from '../../services/northwind.service';

@Component({
  selector: 'app-component-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.sass']
})
export class AppComponentCustomers implements OnInit{

  customers: Array<Customers>=[];
  cust: Customers;
  elementToEdit :Customers;

  constructor(private _serviceNorthwind: ServiceNorthwind){
  }

  ngOnInit(){
    this.GetAllCustomers();
  }


  GetAllCustomers(){
    this._serviceNorthwind.GetAll().subscribe(
      res=>{
        if(res!=null){
          this.customers=res;
        }
      },
      err => {
        alert(`Oops!!, Hubo un error en la conexion para traer los datos: Status error: ${err.status}, Mensaje: ${err.statusText}`)
      })
  }

  edit(id : string){
    this._serviceNorthwind.GetById(id).subscribe(res=>{
      this.elementToEdit=res;
    })
  }

  delete(id:string){
      this._serviceNorthwind.Delete(id).subscribe(
        res=>{
        if(res=="OK"){
          alert("Ok!! Los datos se eliminaron bien...")
          window.location.reload()
        }
      },
      err => {
        alert(`Oops!!, No se puede eliminar este id: Status error: ${err.status}, Mensaje: ${err.error.Message}`)
      });
  }

}
