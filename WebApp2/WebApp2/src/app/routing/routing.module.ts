import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';

import { EmployeeComponent } from '../features/employee/employee.component';
import { EmployeeCreateComponent } from '../features/employee-create/employee-create.component';

let routes: Routes = [
  { path: '', component: EmployeeComponent },
  { path: 'create', component: EmployeeCreateComponent },
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  declarations: [
    EmployeeComponent,
    EmployeeCreateComponent
  ]
})
export class RoutingModule { }
