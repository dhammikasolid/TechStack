// Level 1 feature module
import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router"

// Feature routing 
import { RoutingModule } from "./routing.module";
// Feature container
import { ContainerComponent } from "./components/container.component";
// Feature components
import { ListComponent } from "./components/list.component";

// Level 2 feature modules
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
