import { Component, OnInit } from '@angular/core';
import { Observable, Observer } from 'rxjs';
import { Customers } from '../models/customers';
import { ServiceNorthwind } from '../services/northwind.service';

@Component({
  selector: 'app-component-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.sass']
})
export class AppComponentCustomers implements OnInit{

  customers: Array<Customers>=[];
  elementToEdit :Customers;


  constructor(private _serviceNorthwind: ServiceNorthwind){
  }

  ngOnInit(){
    this.getAllCustomers();
  }

  edit(id : string){
    this._serviceNorthwind.getById(id).subscribe(res=>{
      this.elementToEdit=res;
    })
  }

  delete(id:string){
    this._serviceNorthwind.delete(id).subscribe(
      ()=>{
        alert("Ok!! Los datos se eliminaron bien...")
        this.getAllCustomers();
    },
    err => {      
      alert(`Oops!! Hubo un error, consulte: Status error: ${err.status}, Mensaje: ${err.error.Message}`)
    });
  }

  getAllCustomers(){
    this._serviceNorthwind.getAll().subscribe(
      res=>{
        if(res!=null){
            this.customers=res;
        }
      },
      err => {
        alert(`Oops!!, Hubo un error en la conexion para traer los datos: Status error: ${err.status}, Mensaje: ${err.statusText}`)
      })
  }

  refresh(changed){
    console.log(changed)
    if(changed==true){
      this.getAllCustomers();
    }
  }

}
