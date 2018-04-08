import { Routes } from "@angular/router";

export function MergeRoutes(routesMap: Routes[]) {

    let mergedRoutes: Routes = [];
    for (let routes of routesMap) {
        mergedRoutes = mergedRoutes.concat(routes);
    }
    return mergedRoutes;
}