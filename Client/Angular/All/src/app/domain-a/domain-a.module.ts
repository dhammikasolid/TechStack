import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DomainARoutingModule } from './domain-a-routing.module';
import { DomainA1Module } from './domain-a1/domain-a1.module';

import { DomainAComponent } from './domain-a.component';
import { Feature1Component } from './feature-1/feature-1.component';
import { Feature2Component } from './feature-2/feature-2.component';

@NgModule({
  imports: [
    CommonModule,
    DomainA1Module,
    DomainARoutingModule,
  ],
  declarations: [DomainAComponent, Feature1Component, Feature2Component],
  exports: [DomainAComponent]
})
export class DomainAModule { }
