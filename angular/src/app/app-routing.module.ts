import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {AuthGuard} from './core';
import {HomeComponent} from './home/home.component';
import {LoginComponent} from './login/login.component';
import {DemoApisComponent} from './demo-apis/demo-apis.component';
import {TimetableManagementComponent} from "./timetable-management/timetable-management.component";
import {LayoutComponent} from "./layout/layout.component";

const routes: Routes = [
    {
        path: '',
        component: LayoutComponent,
        canActivate: [AuthGuard],
        children: [
            {
                path: 'timetable-management', component: TimetableManagementComponent,
            },
            {
                path: '', component: HomeComponent
            }
        ]
    },
    {path: 'login', component: LoginComponent},
    {path: 'demo-apis', component: DemoApisComponent, canActivate: [AuthGuard]},
    {
        path: 'management',
        loadChildren: () =>
            import('./management/management.module').then((m) => m.ManagementModule),
        canActivate: [AuthGuard],
    },
    {path: '**', redirectTo: ''},
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {
}
