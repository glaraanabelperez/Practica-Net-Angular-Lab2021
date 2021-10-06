import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponentCustomers } from './components/customers-contain/app.componentCustomers';
import { AppComponentCustomersForms } from './components/customers-contain/customers-form/app.componentCustomersForms';
import { RouterModule, Routes } from '@angular/router';


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
    RouterModule.forRoot(routes),
    FormsModule,
    ReactiveFormsModule,
    CommonModule
  ],
  providers: [],

  bootstrap: [AppComponentCustomers]
  
})
export class AppCustomersModule { }
