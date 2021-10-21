import { Component, OnInit } from '@angular/core';
import { Observable, Observer } from 'rxjs';
import { Customers } from '../models/customers';
import { ServiceInfoCustomers } from '../services/customers-info.service';
import { ServiceNorthwind } from '../services/northwind.service';

@Component({
  selector: 'app-component-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.sass']
})
export class AppComponentCustomers implements OnInit{

  customers: Array<Customers>=[];
  customers$: Observable<Customers[]>;
  cust: Customers;
  elementToEdit :Customers;
  msj_successfull_edition:boolean=false;


  changedCustomers:boolean=false;


  constructor(private _serviceNorthwind: ServiceNorthwind, private _serviceInfoNorthwind: ServiceInfoCustomers){
  }

  ngOnInit(){

    this.customers$=this._serviceInfoNorthwind.getAllCustomers$();
    this.customers$.subscribe(customers => this.customers = customers);
    console.log("aca", this.customers)

  }

  edit(id : string){
    this._serviceNorthwind.GetById(id).subscribe(res=>{
      this.elementToEdit=res;
    })
  }

  delete(id:string){
      this._serviceNorthwind.Delete(id).subscribe(
        ()=>{
          alert("Ok!! Los datos se eliminaron bien...")
          this._serviceInfoNorthwind.setAllCustomers();
      },
      err => {      
        alert(`Oops!! Hubo un error, consulte: Status error: ${err.status}, Mensaje: ${err.error.Message}`)
      });
  }
}
