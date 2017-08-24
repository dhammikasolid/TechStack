import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router"

import { RoutingModule } from "./routing.module";
import { ContainerComponent } from "./components/container.component";
import { ListComponent } from "./components/list.component";

import { Module as ModuleA1 } from "./moduleA1/module";

@NgModule({
    declarations: [
        ContainerComponent,
        ListComponent
    ],
    imports: [
      RouterModule,
      ModuleA1,
      RoutingModule
    ]
})
export class Module { }
