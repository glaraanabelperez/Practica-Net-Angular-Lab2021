import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ServiceNorthwind } from './services/service_northwind.service';
import { HttpClientModule} from '@angular/common/http';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponentCustomers } from './components/customers-contain/app.componentCustomers';
import { AppComponentCustomersForms } from './components/customers-contain/customers-form/app.componentCustomersForms';


const routes: Routes = [
  {path: 'customers', component: AppComponentCustomers},
];


@NgModule({
  declarations: [
    AppComponentCustomers,
    AppComponentCustomersForms,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    FormsModule,
    ReactiveFormsModule,
    CommonModule,
  ],

  providers: [ServiceNorthwind, HttpClientModule],

  bootstrap: [AppComponentCustomers]
  
})
export class AppCustomersModule { }
