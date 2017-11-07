import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router"

// Feature container
import { ContainerComponent } from "./components/container.component";
// Feature components
import { ListComponent } from "./components/list.component";

// Level 3 feature modules
import { Module as A11Module } from "./moduleA11/module";
import { Module as A12Module } from "./moduleA12/module";


@NgModule({
    declarations: [
        ContainerComponent,
        ListComponent
    ],
    imports: [
      RouterModule,
        A11Module,
        A12Module
    ]
})
export class Module { }
