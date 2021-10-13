import { Component, OnInit } from '@angular/core';
import { Customers } from '../../models/customers';
import { ServiceNorthwind } from '../../services/service_northwind.service';

@Component({
  selector: 'app-component-customers',
  templateUrl: './app.componentCustomers.html',
  styleUrls: ['./app.componentCustomers.sass']
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
        alert("Oops!!, Hubo un error para traer los datos")
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
          window.location.reload()
          alert("Ok!! Los datos se eliminaron bien...")
        }
      },
      err => {
        alert("Oops!!, Los datos estan siendo usados por el sistema, no pueden eliminarse ..." + err)
      });
  }

}
