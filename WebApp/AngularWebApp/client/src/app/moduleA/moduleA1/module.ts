﻿import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router"

import { ContainerComponent } from "./components/container.component";
import { ListComponent } from "./components/list.component";

import { Module as A11Module} from "./moduleA11/module";

@NgModule({
    declarations: [
        ContainerComponent,
        ListComponent
    ],
    imports: [
      RouterModule,
      A11Module
    ]
})
export class Module { }