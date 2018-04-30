import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { DomainA1Component } from './domain-a1.component';
import { Featuer1Component } from './featuer-1/featuer-1.component';
import { Featuer2Component } from './featuer-2/featuer-2.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule
  ],
  declarations: [DomainA1Component, Featuer1Component, Featuer2Component]
})
export class DomainA1Module { }
