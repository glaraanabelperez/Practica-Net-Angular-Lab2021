import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ServiceNorthwind } from './customers/services/northwind.service';
import { HttpClientModule} from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ToastrModule } from 'ngx-toastr';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponentShippers } from './shippers/shippers.component';
import { AppComponentCustomers } from './customers/components/customers.component'
import { AppComponentCustomersForms } from './customers/components/customers-form/formCustomer.component'
import { AppComponentNorthwind } from './northwind.component';
import { HomeNorthwind } from './home/home-northwind.component';

export const childrenRoute:Routes=[
    {path: 'customers', component: AppComponentCustomers},
    {path: 'shippers', component: AppComponentShippers},
    {path: 'home', component: HomeNorthwind},

]

const routes: Routes = [
  {path: '', redirectTo: 'northwind/home', pathMatch:'full'},
  {path: 'northwind', component: AppComponentNorthwind, children: childrenRoute},
];



@NgModule({
  declarations: [
    HomeNorthwind,
    AppComponentCustomers,
    AppComponentCustomersForms,
    AppComponentShippers,
    AppComponentNorthwind
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(routes),
    CommonModule,
  ],
  // schemas: [ 
  //   CUSTOM_ELEMENTS_SCHEMA, 
  // ],
  providers: [ HttpClientModule,ServiceNorthwind],

  bootstrap: []
  
})
export class AppNorthwindModule { }
