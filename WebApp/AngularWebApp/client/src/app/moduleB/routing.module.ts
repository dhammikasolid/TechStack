import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { ListComponent } from "./components/list.component";
import { DetailComponent } from "./components/detail.component";

const routes: Routes = [
    { path: "b", component: ListComponent },
    { path: "b/:id", component: DetailComponent }
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ]
})
export class RoutingModule { }
