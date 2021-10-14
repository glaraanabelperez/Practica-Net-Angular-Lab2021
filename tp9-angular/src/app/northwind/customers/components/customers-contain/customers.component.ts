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
          alert("Ok!! Los datos se eliminaron bien...")
          window.location.reload()
        }
      },
      err => {
        alert("Oops!!, Elimine un id nuevo, este id esta siendo usado por otros datos ...")
      });
  }

}
