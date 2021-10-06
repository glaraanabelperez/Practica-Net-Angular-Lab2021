import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponentCustomers } from './northwind-components/northwind-components-customers/app.componentCustomers';
import { AppComponentCustomersForms } from './northwind-components/northwind-components-customers/northwind-component-customers-form/app.componentCustomersForms';


@NgModule({
  declarations: [
    AppComponentCustomers,
    AppComponentCustomersForms
  ],

  imports: [
  ],

  providers: [],

  bootstrap: [AppComponentCustomers]
  
})
export class AppNorthwindModule { }
