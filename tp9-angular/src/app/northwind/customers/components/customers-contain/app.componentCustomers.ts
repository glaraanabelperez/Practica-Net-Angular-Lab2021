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
    // this.customers=new Array<Customers>();
  }

  ngOnInit(){
    this.GetAllCustomers();
  }

  GetAllCustomers(){
    this._serviceNorthwind.GetAll().subscribe(res=>{
      this.customers=res;
      console.log(this.customers);
    })
  }

  edit(id : string){
    this._serviceNorthwind.GetById(id).subscribe(res=>{
      this.elementToEdit=res;
      console.log(this.elementToEdit);
    })
  }

}
