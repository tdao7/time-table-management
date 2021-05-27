import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';

import {CoreModule} from './core/core.module';

import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {LoginComponent} from './login/login.component';
import {HomeComponent} from './home/home.component';
import {DemoApisComponent} from './demo-apis/demo-apis.component';
import {TimetableManagementComponent} from './timetable-management/timetable-management.component';
import {LayoutComponent} from './layout/layout.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatButtonModule} from "@angular/material/button";
import {MatIconModule} from "@angular/material/icon";
import {AddScheduleComponent} from './timetable-management/dialogs/add-schedule/add-schedule.component';
import {MatDialogModule} from '@angular/material/dialog';
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatSelectModule} from "@angular/material/select";
import {MatOptionModule} from "@angular/material/core";
import {MatTooltipModule} from "@angular/material/tooltip";
import {MatDatepickerModule} from "@angular/material/datepicker";
import {MatInputModule} from "@angular/material/input";
import { MatNativeDateModule } from '@angular/material/core';
import { AddTimetableComponent } from './timetable-management/dialogs/add-timetable/add-timetable.component';


@NgModule({
    declarations: [
        AppComponent,
        LoginComponent,
        HomeComponent,
        DemoApisComponent,
        TimetableManagementComponent,
        LayoutComponent,
        AddScheduleComponent,
        AddTimetableComponent,
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpClientModule,
        CoreModule,
        AppRoutingModule,
        BrowserAnimationsModule,
        MatButtonModule,
        MatIconModule,
        MatDialogModule,
        MatFormFieldModule,
        MatSelectModule,
        MatOptionModule,
        MatTooltipModule,
        MatDatepickerModule,
        MatInputModule,
        MatNativeDateModule,
        ReactiveFormsModule
    ],
    providers: [],
    bootstrap: [AppComponent],
})
export class AppModule {
}
