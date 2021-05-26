import {Component, OnInit, ViewChild} from '@angular/core';
import {AuthService} from '../core';
import {Router} from "@angular/router";


@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {
    accessToken = '';
    refreshToken = '';

    listFeatures = [
        {code: 0, name: "Quản lý sinh viên", description: "Chức năng quản lý sinh viên", routerLink: '', isReleased: false},
        {code: 1, name: "Quản lý lớp", description: "Chức năng quản lý lớp", routerLink: '', isReleased: false},
        {code: 2, name: "Quản lý môn học", description: "Chức năng quản lý môn học", routerLink: '', isReleased: false},
        {code: 3, name: "Quản lý phòng học", description: "Chức năng quản lý phòng học", routerLink: '', isReleased: false},
        {
            code: 4,
            name: "Quản lý thời khoá biểu",
            description: "Chức năng quản lý thời khoá biểu",
            routerLink: '/timetable-management',
            isReleased: true
        },
    ]

    constructor(
        public authService: AuthService,
        private router: Router
    ) {

    }

    ngOnInit(): void {
        this.accessToken = localStorage.getItem('access_token');
        this.refreshToken = localStorage.getItem('refresh_token');
    }

    redirect(feature: {code: number; routerLink: string; name: string; description: string; isReleased: boolean} | {code: number; routerLink: string; name: string; description: string; isReleased: boolean} | {code: number; routerLink: string; name: string; description: string; isReleased: boolean} | {code: number; routerLink: string; name: string; description: string; isReleased: boolean} | {code: number; routerLink: string; name: string; description: string; isReleased: boolean}) {
        if (feature.isReleased) {
            this.router.navigate([feature.routerLink]);
        }
    }
}
